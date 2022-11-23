// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



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

        reader = new FileReader()

        let fd = new FormData();
        fd.append('image', file);


        
        
        fetch('https://localhost:7156/User/UpdateProfilePicture', {
            method: 'POST', // or 'PUT'
            headers: {
                
            },
            body:fd
            })
            .then((response) => response.json())
            .then((data) => {
                document.getElementById('profile-pic').src = data
            })
            .catch((error) => {
                console.error('Error:', error);
            });






    })
}