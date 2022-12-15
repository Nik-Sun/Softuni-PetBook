import { getCityData, initMapReg } from './initMapReg.js'
import {displayModal,hideModal } from './modal.js'
const basePath = document.location.protocol + '//' + document.location.host + '/';
document.getElementById('profile-pic-container').addEventListener('click', uploadImage);
const uploadUrl = `${basePath}User/UpdateProfilePicture`;
const selectCity = document.getElementById('select-city');
selectCity.addEventListener('change', cityChanged);
document.querySelector('#change-address-btn').addEventListener('click',changeAddress)


function uploadImage() {
    let inputEl = document.getElementById('profile-pic-upload');
    inputEl.click();
    inputEl.onchange = (function (e) {

        let file = e.target.files[0];
        let fd = new FormData();
        fd.append('image', file);

        fetch(uploadUrl, {
            method: 'POST', // or 'PUT'
            headers: {

            },
            body: fd
        })
            .then((response) => response.json())
            .then((data) => {
                document.getElementById('profile-pic').src = data
                console.log(document.querySelector('.text-danger').style.display = '');
                console.log(inputEl.files[0]);
            })
            .catch((error) => {
                console.error('Error:', error);
            });
    })
}
 function cityChanged() {
    let modal = document.getElementById('modal-one');
    displayModal(modal)
    modal.querySelectorAll('.close').forEach(e => e.addEventListener('click', () => {
        hideModal(modal)
        selectCity.selectedIndex = 0;
    }))
    modal.querySelector('.btn-primary').addEventListener('click',async () => {
        await hideModal(modal)
        changeAddress()
    })
}



async function changeAddress(e) {
    if (e) {
        e.preventDefault();
    }

    let cityId = selectCity.value;
    console.log(cityId);
    let cityData = await getCityData(cityId)
    console.log(cityData);
    
    let modal = document.querySelector('#modal-map')
    displayModal(modal)
    initMapReg(cityData)
    
    document.querySelector('#autocomp-support-form').addEventListener('submit', (e) => {
        e.preventDefault();

        let lat = document.querySelector('#lat').value;
        let lng = document.querySelector('#lng').value;
        let addressText = document.querySelector('#location-input').value;

        if (lat && lng) {
            console.log(lat, lng);
            modal.classList.remove('show');
            modal.classList.remove('fade')
            modal.classList.replace('modal-open', 'modal')

            document.querySelector('#Address').value = addressText;
            document.querySelector('#Latitude').value = lat;
            document.querySelector('#Longitude').value = lng;
        }

    })

    document.querySelector('.btn-close').addEventListener('click', () => {
        hideModal(modal)
    })
