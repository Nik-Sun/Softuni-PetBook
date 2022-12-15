import { displayModal,hideModal }  from './modal.js'

document.querySelectorAll('#img-tag').forEach(e => e.addEventListener('click', showImage))
document.querySelector('.modal').addEventListener('mousemove', showTooltip)
document.getElementById('Images').addEventListener('input',imageConuntHandler)
document.getElementById('del-btn').addEventListener('click', warnOnDelete)
const zoomedImgElement = document.getElementById('zoom')

function showImage(e) {
    console.log(e.currentTarget);
    e.preventDefault();
    zoomedImgElement.children[0].src = e.currentTarget.href;
    zoomedImgElement.classList.replace('modal','modal-open')
    zoomedImgElement.addEventListener('click',() => zoomedImgElement.classList.replace('modal-open','modal'))

}

function showTooltip(e) {
    let x = e.clientX;
    let y = e.clientY;
    document.getElementById("tooltip").style.left = x + "px";
    document.getElementById("tooltip").style.top = y + "px";
}

function imageConuntHandler(e) {
    let input = e.currentTarget;
    let imgMsgEl = document.getElementById('img-count-msg')
    if (validateFiles(input, imgMsgEl)) {

        let existingImagesCount = Number(document.getElementById('img-count').value)
        let count = Number(input.files.length);


        if (count + existingImagesCount < 12) {
            imgMsgEl.classList.remove('text-danger')
            imgMsgEl.textContent = `Selected ${count} images.Click save changes`

        }
        else {
            imgMsgEl.classList.add('text-danger')
            imgMsgEl.textContent = 'You cannot upload more than 12 images'
            input.value = ''
        }

    }

}

function validateFiles(input,output) {
    for (var i = 0; i < input.files.length; i++) {
        if (input.files[i].type != 'image/jpg' && input.files[i].type != 'image/jpeg') {
            output.classList.add('text-danger')
            output.textContent = "Unsupported file Type: " + `${input.files[i].type}`
            input.value = ''
            return false;
        }
    }
    return true;
}

function warnOnDelete(e) {
    
    e.preventDefault();
    let delBtn = e.currentTarget;
    let modal = document.getElementById('modal-delete');
    displayModal(modal)
    modal.querySelectorAll('.close').forEach(e => e.addEventListener('click', () => {
        hideModal(modal)
    }))
    modal.querySelector('#confirm').addEventListener('click', async () => {
        hideModal(modal)
        delBtn.click();
       window.location.href = delBtn.href
    })
}