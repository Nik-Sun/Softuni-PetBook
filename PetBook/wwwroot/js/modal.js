function displayModal(modal) {

    modal.classList.add('fade')
    modal.classList.replace('modal', 'modal-open')
    setTimeout(() => modal.classList.add('show'), 20)

}

function hideModal(modal) {
    modal.classList.remove('show');
    setTimeout(() => {
        modal.classList.remove('fade')
        modal.classList.replace('modal-open', 'modal')
    }, 150)
}

export { displayModal, hideModal }