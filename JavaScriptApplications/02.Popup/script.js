(function () {
    let div = document.getElementById('redirect'),
        btn = document.getElementById('button');

    function showDiv() {
        btn.style.display = 'none';
        div.style.display = 'block';
    }

    function redirecting() {
        window.location = 'https://telerikacademy.com/';
    }

    let promise = new Promise(function (resolve, reject) {
        setTimeout(function () {
            resolve();
        }, 2000);
    })

    function onError() {
        div.innerText = 'Error! Refresh page and try again please!';
    }

    function onClick() {
        showDiv();

        promise
            .then(redirecting)
            .catch(onError)
    }

    window.onload = btn.addEventListener('click', onClick, false);
}());