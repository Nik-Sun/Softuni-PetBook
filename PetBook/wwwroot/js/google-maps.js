"use strict";

 async function initMap(cityId) {
    let cityData;
    await fetch(`https://localhost:7156/Api/City/${cityId}`, {
        method: 'get'
    })
        .then(res => res.json())
        .then(data => cityData = data)
        .catch(err => console.log(err))
    console.log(cityData);
    const CONFIGURATION = {
        "ctaTitle": "Checkout",
        "mapOptions": { "center": { "lat": 37.4221, "lng": -122.0841 }, "fullscreenControl": true, "mapTypeControl": false, "streetViewControl": true, "zoom": 11, "zoomControl": true, "maxZoom": 22, "mapId": "" },
        "mapsApiKey": "AIzaSyAZa7jwNGAWgJZ-BbsAId3LPB4Id90WJSE",
        "capabilities": { "addressAutocompleteControl": true, "mapDisplayControl": true, "ctaControl": false }
    };
    const componentForm = [
        'location',
        'locality',
        'administrative_area_level_1',
        'country',
        'postal_code',
    ];

    const getFormInputElement = (component) => document.getElementById(component + '-input');
    const map = new google.maps.Map(document.getElementById("gmp-map"), {
        zoom: CONFIGURATION.mapOptions.zoom,
        center: { lat: cityData.lattitude, lng: cityData.longitude },
        mapTypeControl: false,
        fullscreenControl: CONFIGURATION.mapOptions.fullscreenControl,
        zoomControl: CONFIGURATION.mapOptions.zoomControl,
        streetViewControl: CONFIGURATION.mapOptions.streetViewControl
    });
     let cityCoords = { lat: cityData.lattitude, lng:cityData.longitude };

    // Create a bounding box with sides ~10km away from the center point
    const defaultBounds = {
        north: cityCoords.lat + 0.1,
        south: cityCoords.lat - 0.1,
        east: cityCoords.lng + 0.1,
        west: cityCoords.lng - 0.1,
    };


    const marker = new google.maps.Marker({ map: map, draggable: true });
    const autocompleteInput = getFormInputElement('location');
    let autocomplete = new google.maps.places.Autocomplete(autocompleteInput, {
        fields: ["address_components", "geometry", "name"],
        types: ["address"],
        bounds: defaultBounds
    });
    autocomplete.setComponentRestrictions({
        country: ["bg"],

    });
    autocomplete.addListener('place_changed', function () {
        marker.setVisible(false);
        const place = autocomplete.getPlace();
        if (!place.geometry) {
            // User entered the name of a Place that was not suggested and
            // pressed the Enter key, or the Place Details request failed.
            window.alert('No details available for input: \'' + place.name + '\'');
            return;
        }
        renderAddress(place);
        // fillInAddress(place);
    });

    function fillInAddress(place) {  // optional parameter
        const addressNameFormat = {
            'street_number': 'short_name',
            'route': 'long_name',
            'locality': 'long_name',
            'administrative_area_level_1': 'short_name',
            'country': 'long_name',
            'postal_code': 'short_name',
        };
        const getAddressComp = function (type) {
            for (const component of place.address_components) {
                if (component.types[0] === type) {
                    return component[addressNameFormat[type]];
                }
            }
            return '';
        };
        //getFormInputElement('location').value = getAddressComp('street_number') + ' '
        //    + getAddressComp('route');
        //for (const component of componentForm) {
        //    // Location field is handled separately above as it has different logic.
        //    if (component !== 'location') {
        //        getFormInputElement(component).value = getAddressComp(component);
        //    }
        //}
    }

    function renderAddress(place) {
        map.setCenter(place.geometry.location);
        marker.setPosition(place.geometry.location);
        marker.setVisible(true);
        document.getElementById('lng').value = place.geometry.location.lng();
        document.getElementById('lat').value = place.geometry.location.lat();
        marker.addListener('dragend', function () {
            var pos = marker.getPosition();
            document.getElementById('lng').value = pos.lng();
            document.getElementById('lat').value = pos.lat();
        })

    }
}