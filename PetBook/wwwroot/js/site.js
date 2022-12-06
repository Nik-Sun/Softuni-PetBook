// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const uploadUrl = 'https://localhost:7156/User/UpdateProfilePicture'
const likeUrl = 'https://localhost:7156/Api/Like'



function loadImage(event) {
    event.preventDefault()
    let mainEl = document.getElementById('main');
    let clickedEl = event.target;
    let mainUrl = mainEl.src;
    let clickedUrl = event.target.src;

    mainEl.src = clickedUrl;
    clickedEl.src = mainUrl;
    console.log('end')
}

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
function changePage(event) {
    let buttonClicked = event.currentTarget.id;
    let currentPage = document.getElementById('page-number').textContent
    if (buttonClicked == 'prev') {
        currentPage--;
    }
    else {
        currentPage++;
    }
    console.log(buttonClicked);
    console.log(currentPage);
    location.href = `https://localhost:7156/Pet/Browse/${currentPage}`;
}

function addLike(e) {
    e.preventDefault();
    let target = e.currentTarget;
    let petId = target.id;
    console.log(e, petId);
    fetch(`${likeUrl}/${petId}`, {
        method: 'post'
    }).then(e => e.json())
        .then(res => {
            let likesElement = target.querySelector('.badge');
            likesElement.textContent = res
            likesElement.parentElement.classList.add('bi-heart-fill');
            likesElement.parentElement.classList.remove('bi-heart');
            document.getElementById(petId).setAttribute('disabled', 'true');
        })
        .catch(e => console.log(e))
}

function registerFirstStage(e) {
    e.preventDefault();
    let cityId = document.getElementById('CityId').value;
    initMap(cityId)
    document.getElementById('reg-f').style.display = 'none';
    document.getElementById('reg-s').style.display = 'flex';
    document.getElementById('reg-btn').style.display = 'flex';

}

function GetNearbyUsers() {
    fetch(`https://localhost:7156/NearbyUsers/NearbyUsers`, {
        method: 'get'
    })
        .then(res => res.json())
        .then(data => initMap(data))
        .catch(err => console.log(err))
}
function populateSearchField(event) {

    let searchBox = document.getElementById('search-box')
    let altSearch = document.getElementById('alt-search');
    if (event.currentTarget.value == 'size') {
       
        searchBox.setAttribute('hidden', "")
        
        altSearch.addEventListener('change', (e) => {
            searchBox.value = e.currentTarget.value;

        })
        altSearch.removeAttribute('hidden');
    } else {
        altSearch.setAttribute('hidden', '')
        searchBox.removeAttribute('hidden')
    }
  
    
   
}