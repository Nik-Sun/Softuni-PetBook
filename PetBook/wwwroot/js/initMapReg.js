import { loader } from './site.js'
const basePath = document.location.protocol + '//' + document.location.host + '/';

async function getCityData(cityId) {

    let cityData;
    await fetch(`${basePath}Api/City/${cityId}`, {
        method: 'get'
    })
        .then(res => res.json())
        .then(data => cityData = data)
        .catch(err => console.log(err))

    return cityData;
}


/**
 * 
 * @param {{lat:number,lng:number}} cityData
 */

function initMapReg(cityData) {
    let formElement = document.querySelector('#autocomp-support-form')
    let latEl = document.getElementById('lat');
    let lngEl = document.getElementById('lng');
    let pos = {};
    const CONFIGURATION = {
        "mapOptions": { "fullscreenControl": true, "mapTypeControl": false, "streetViewControl": true, "zoom": 17, "zoomControl": true, "maxZoom": 22, "mapId": "" },
        "capabilities": { "addressAutocompleteControl": true, "mapDisplayControl": true, "ctaControl": false }
    };

    loader.load()
        .then(google => {

            const autocompleteInput = document.getElementById('location-input');
            
            const map = new google.maps.Map(document.getElementById("gmp-map"), {
                zoom: CONFIGURATION.mapOptions.zoom,
                center: { lat: cityData.lattitude, lng: cityData.longitude },
                mapTypeControl: false,
                fullscreenControl: CONFIGURATION.mapOptions.fullscreenControl,
                zoomControl: CONFIGURATION.mapOptions.zoomControl,
                streetViewControl: CONFIGURATION.mapOptions.streetViewControl
            });

            let cityCoords = { lat: cityData.lattitude, lng: cityData.longitude };

            // Create a bounding box with sides ~10km away from the center point
            const defaultBounds = {
                north: cityCoords.lat + 0.1,
                south: cityCoords.lat - 0.1,
                east: cityCoords.lng + 0.1,
                west: cityCoords.lng - 0.1,
            };


            const marker = new google.maps.Marker({ map: map, draggable: true });

            autocompleteInput.addEventListener('input', () => {
                formElement.querySelector('#map-form-btn').setAttribute('disabled', true);
                document.getElementById('marker-info').style.display = 'none';
                latEl.value = '';
                lngEl.value = '';
                marker.setVisible(false)
            })

            const autocomplete = new google.maps.places.Autocomplete(autocompleteInput, {
                fields: ["address_components", "geometry", "name"],
                types: ["address"],
                bounds: defaultBounds
            });

            autocomplete.setComponentRestrictions({
                country: ["bg"],

            });

            autocomplete.addListener('place_changed', renderAddress);
            
            function isPlaceValid(place) {
                if (!place || !place.geometry) {
                    return false;
                }
                return true;
            }


            function renderAddress() {

                let place = autocomplete.getPlace();
                console.log(place);
                if (isPlaceValid(place)) {
                    map.setCenter(place.geometry.location);
                    map.setZoom(17);
                    marker.setPosition(place.geometry.location);
                    marker.setVisible(true);
                    document.getElementById('lng').value = place.geometry.location.lng();
                    document.getElementById('lat').value = place.geometry.location.lat();
                    formElement.querySelector('#map-form-btn').removeAttribute('disabled')
                    document.getElementById('marker-info').style.display = 'block'
                    marker.addListener('dragend', function () {
                        pos = marker.getPosition();
                        lngEl.value = pos.lng();
                        lat.value = pos.lat();
                    })

                }
                else {
                    window.alert("No details available for input: '" + place.name + "'");
                }
            }
        })

}
export { getCityData, initMapReg }