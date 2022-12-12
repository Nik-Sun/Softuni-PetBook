const basePath = document.location.protocol + '//' + document.location.host + '/';

const likeUrl = `${basePath}api/like`
let searchBox = document.getElementById('search-box');
let altSearch = document.getElementById('alt-search');
let criteriaDropdown = document.querySelector('#Criteria');
let altSearchVal = document.getElementById('alt-search-val');

altSearch.addEventListener('change', (e) => {
    searchBox.value = e.currentTarget.value;

})
document.getElementById('prev').addEventListener('click', changePage);
document.getElementById('next').addEventListener('click', changePage);
document.querySelectorAll('#like-btn').forEach(btn => btn.addEventListener('click', addLike))
criteriaDropdown.addEventListener('change', populateSearchField)


if (criteriaDropdown.selectedIndex == 2) {
    let event = new Event('change');
    criteriaDropdown.dispatchEvent(event)
}

document.querySelector('button[type="submit"]').addEventListener('click', (e) => {
    if (searchBox.value == "" && searchBox.hasAttribute('hidden')) {
        e.preventDefault()
        altSearchVal.textContent = "Choose size";
        altSearch.addEventListener('change', () => {
            altSearchVal.textContent = '';
        })
    }

})

function addLike(e) {
    console.log(e);
    e.preventDefault();
    let target = e.currentTarget;
    let petId = target.getAttribute('data-id');
    console.log(e, petId);
    fetch(`${likeUrl}/${petId}`, {
        method: 'post'
    }).then(e => e.json())
        .then(res => {
            let likesElement = target.querySelector('.badge');
            likesElement.textContent = res
            likesElement.parentElement.classList.add('bi-heart-fill');
            likesElement.parentElement.classList.remove('bi-heart');
            document.getElementById('like-btn').setAttribute('disabled', 'true');
        })
        .catch(e => console.log(e))
}
function changePage(event) {
    console.log('fire');
    let buttonClicked = event.currentTarget.id;
    let currentPage = document.getElementById('page-number').textContent

    if (buttonClicked == 'prev') {
        currentPage--;
    }
    else {
        currentPage++;
    }

    location.href = `${basePath}Pet/Browse/${currentPage}`;
}
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
function populateSearchField(event) {


    if (event.currentTarget.value == 'size') {

        searchBox.setAttribute('hidden', "")

       
        altSearch.removeAttribute('hidden');
        searchBox.value = ""
    } else {
        altSearch.setAttribute('hidden', '')
        searchBox.value = ""
        searchBox.removeAttribute('hidden')
        searchBox.focus()
    }



}


