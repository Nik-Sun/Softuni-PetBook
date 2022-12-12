import { loader } from './site.js'
window.addEventListener('load', GetNearbyUsers)
const basePath = document.location.protocol + '//' + document.location.host + '/';

function GetNearbyUsers() {

    fetch(`${basePath}NearbyUsers/NearbyUsers`, {
        method: 'get'
    })
        .then(res => res.json())
        .then(data => initMap(data))
        .catch(err => console.log(err))
}


let map;
let infoWindow;

function initMap(data) {
    console.log(data);
    loader.load()
        .then(google => {


            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: data[0].lat, lng: data[0].lng },
                zoom: 17,
                mapId: 'map'
            })
            
            infoWindow = new google.maps.InfoWindow();

            // Create markers.
            let markers = createMarkers(data)
            const bounds = new google.maps.LatLngBounds();
            for (var i = 0; i < markers.length; i++) {
                bounds.extend(markers[i].position)
            }

            map.fitBounds(bounds);

        })

}

function createMarkers(data) {
    
    let markers = [];
    for (let i = 0; i < data.length; i++) {
        const icon = document.createElement("div");
        icon.innerHTML = '<i style="scale:1.5" class="fa-solid fa-dog"></i>';
        const pinView = new google.maps.marker.PinView({
            glyph: icon,
            glyphColor: "#4c62c1",
            background: " #9ae61d",
            borderColor: "#4c62c1",
            scale: 1.5
        });
        const pos = new google.maps.LatLng(data[i].lat, data[i].lng)
        const marker = new google.maps.marker.AdvancedMarkerView({
            map: map,
            position: pos,
            content: pinView.element,
            title: `${data[i].petName}`
        });

        marker.addListener("click", (event) => {
            console.log(event);
            if (infoWindow) {
                infoWindow.close();
            }
            infoWindow.setContent(data[i].petName);
            infoWindow.open(marker.map, marker);
        });
        markers.push(marker);
        console.log(marker);
    }
    return markers;
}
