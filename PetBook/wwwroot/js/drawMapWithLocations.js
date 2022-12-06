
let map;

async function initMap(data) {
    const { AdvancedMarkerView } = await google.maps.importLibrary("marker");
    const icon = document.createElement("div");
    const map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: data[0].lat, lng: data[0].lng },
        zoom: 17,
        mapId:'map'
    })
    icon.innerHTML = '<i style="scale:1.5" class="fa-solid fa-dog"></i>';

    const faPinView = new google.maps.marker.PinView({
        glyph: icon,
        glyphColor: "#4c62c1",
        background: " #9ae61d",
        borderColor: "#4c62c1",
        scale: 1.5
    });

   
    
    const infoWindow = new google.maps.InfoWindow();
    
    // Create markers.
    for (let i = 0; i < data.length; i++) {
        const marker = new google.maps.marker.AdvancedMarkerView({
            map,
            position: { lat: data[i].lat, lng: data[i].lng },
            content: faPinView.element,
            title: `${data[i].lng}`
        });
        marker.addListener("click", () => {
           
            if (infoWindow) {
                infoWindow.close();
            }
            infoWindow.setContent(marker.title);
            infoWindow.open(marker.map, marker);
        });

        console.log(marker);
    }
}

window.initMap = initMap;