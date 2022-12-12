import { initMapReg,getCityData} from './initMapReg.js'

const basePath = document.location.protocol +'//'+ document.location.host +'/';
console.log(basePath);

const proceedBtn = document.getElementById('reg-proceed');
proceedBtn.addEventListener('click', registerProceed)
let formElement = document.querySelector('#reg-form');


let passClosure;
const validate = {

    FirstName: {
        func: (val) => {
            if (val && val.length >= 2) {
                return true;
            }
            return false;
        },
        msg: 'Invalid Firstname'
    },
    LastName: {
        func: (val) => {
            if (val && val.length >= 2) {
                return true;
            }
            return false;
        },
        msg: 'Invalid Lastname'
    },
    Username: {
        func: async (val) => {
            if (val.includes('/')) {
                return false
            }
           return fetch(`${basePath}/Api/CheckUsername/${val}`)
                .then(res => res.json())
                .then(result => result)
                .catch(e => console.log(e))
        },
        msg: "Username is already taken"
    },
    Email: {
        func: (val) => {
            if (/^[a-zA-Z0-9.!#$%&'*+\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/.test(val)) {
                return true;
            }
            return false;
        },
        msg: "The Email field is not a valid e-mail address."
    },
    Password: {
        func: (val => {

            if (val && val.length >= 6) {
                passClosure = val
                return true
            }
            return false
        }),
        msg: 'Invalid password'
    },
    ConfirmPassword: {
        func: (val) => {
            if (val === passClosure) {
                return true;
            }
            return false
        },
        msg: 'Passwords do not match'
    }
}

async function registerProceed(e) {
    document.querySelectorAll('span').forEach(e => e.textContent = '')

    formElement.querySelectorAll('input').forEach(ie => ie.addEventListener('focusout', formValidate))
    e.preventDefault();

    let isValid = await formValidate()

    if (isValid) {
        let cityId = document.getElementById('CityId').value;
        let cityData = await getCityData(cityId);
        initMapReg(cityData)
        formElement.style.display = 'none';
        document.getElementById('reg-s').style.display = 'flex';

        document.querySelector('#autocomp-support-form').addEventListener('submit',submitRegistration)
    }

}
async function formValidate() {
    let form = new FormData(document.querySelector('form'));
    let isValid = true;

    for (var pair of form.entries()) {
        if (validate[pair[0]]) {
            let result = await validate[pair[0]].func(pair[1]);
            console.log(result);
            console.log(validate[pair[0]],validate[pair[1]]);
            if (!result) {
                document.querySelector(`[data-valmsg-for=${pair[0]}]`).textContent = validate[pair[0]].msg
                isValid = false
            } else {
                document.querySelector(`[data-valmsg-for=${pair[0]}]`).textContent = ''
            }
        }

    }

    return isValid;

}

function submitRegistration(e) {
    e.preventDefault();

    let lat = document.getElementById('lat').value;
    let lng = document.getElementById('lng').value;
    let addressText = document.getElementById('location-input').value;
    if (lat && lng) {
        document.getElementById('Latitude').value = lat;
        document.getElementById('Longitude').value = lng;
        document.getElementById('Address').value = addressText;
        formElement.submit();
    }
}

