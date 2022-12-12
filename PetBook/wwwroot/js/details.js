document.querySelectorAll('.my-class a').forEach(a => a.addEventListener('click', loadImage));



function loadImage(event) {
    event.preventDefault()
    let mainEl = document.getElementById('main');
    let clickedEl = event.target;
    let mainUrl = mainEl.src;
    let clickedUrl = event.target.src;

    mainEl.src = clickedUrl;
    clickedEl.src = mainUrl;
   
}