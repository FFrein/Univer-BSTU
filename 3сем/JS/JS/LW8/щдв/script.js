const stateReg = document.querySelector('.reg');
const stateAuto = document.querySelector('.auto');
let _email;
let _password;
let _name;
let inputs;
let buttonReg;
let isClicked = false;
const regs = {
    email: new RegExp(/^[a-zA-Z0-9_.]+@[a-z]+\.[a-z]+$/),
    name: new RegExp(/^[a-zA-Z]{2,}$/),
    password: new RegExp(/^[a-zA-Z0-9_.]{8,64}$/)
    };
stateAuto.onclick = () => {
    isClicked = false;
    regestration(".Email1", ".Password1", ".Button1", ".Name1");
};
stateReg.onclick = () => {
    if (!isClicked) {
        isClicked = true;
        regestration(".Email", ".Password", ".button-reg", ".Name");
    }
};

function regestration(email, pass, but, name) {
    let resEmail;
    let resPassword;
    let resName;
    _email = document.querySelector(email);

    _password = document.querySelector(pass);
    _name = document.querySelector(name);
    buttonReg = document.querySelector(but);
    buttonReg.onclick = () => {
        resEmail = testEmail(_email);
        resPassword = testPassword(_password);
        resName = testName(_name);

        console.log(resEmail, resPassword, resName);

        if (!resPassword) {
            _password.value = "";
            _password.placeholder = "Password is not valid";
            setTimeout(() => {
                if (_password.placeholder == "Password is not valid") {
                    _password.placeholder = "Введите пароль";
                }
            }, 2000);
        }

        if (!resEmail) {
        _email.value = "Ошибка в почте";
        setTimeout(() => {
            if (_email.value == "Ошибка в емаиле") {
                _email.value = "";
            }
        }, 2000);
        }

        if (!resName) {
            _name.value = "Ошибка в имени";
            setTimeout(() => {
                if (_name.value == "Ошибка в имени") {
                    _name.value = "";
                }
            }, 2000);
        }
    };
}



function testEmail(email) {
    return regs.email.test(email.value);
}

function testPassword(password) {
    return regs.password.test(password.value);
}

function testName(name) {
    return regs.name.test(name.value);
}