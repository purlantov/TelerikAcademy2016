function _ClickON_TheButton(THE_event, argumenti) {
    var moqProzorec = window,
        brauzyra = moqProzorec.navigator.appCodeName,
        ism = brauzyra == "Mozilla";

    if (ism) {
        alert("Yes");
    } else {
        alert("No");
    }
}

//var event = (function () {
//    function clickedButton() {
//        var browserName = window.navigator.appCodeName,
//            isMozilla = (browserName === 'Mozilla');

//        if (isMozilla) {
//            alert('You are running this script in Mozilla!');
//        } else {
//            alert('You are NOT running this script in Mozilla!');
//        }
//    }

//    return {
//        buttonClick: clickedButton
//    };
//}());