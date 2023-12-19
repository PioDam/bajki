let title = document.querySelector("#title");
let miniature = document.querySelector("#miniature");
let picture = document.querySelector("#picture");
let paragraph1 = document.querySelector("#paragraph1");
let paragraph2 = document.querySelector("#paragraph2");
let paragraph3 = document.querySelector("#paragraph3");
let paragraph4 = document.querySelector("#paragraph4");
let paragraph5 = document.querySelector("#paragraph5");
let paragraph6 = document.querySelector("#paragraph6");
let paragraph7 = document.querySelector("#paragraph7");
let paragraph8 = document.querySelector("#paragraph8");
let paragraph9 = document.querySelector("#paragraph9");
let button = document.querySelector("#add-button");
check1 = 0;
check2 = 0;
check3 = 0;
check4 = 0;


red = "2px solid red"
green = "2px solid green"
grey = "2px solid grey"






/*title.style.border = "2px solid red";*/

function check(element) {

    if (element.value == "") {
        element.style.border = red;
        return 0;
    }
    else {
        element.style.border = green;
        return 1;
    }
    
}
function checkGreen(element) {
    if (element.value != "") {
        element.style.border = green;
    }
    else {
        element.style.border = grey;
    }
}

function checkButton() {
    if (check1 != 0 && check2 != 0 && check3 != 0 && check4 != 0) {
        button.removeAttribute("disabled");
    }
    else {
        button.setAttribute("disabled","disabled");
    }
}


title.addEventListener("input", function () {
    check1 = check(title);
    checkButton();
});

miniature.addEventListener("input", function () {
    check2 = check(miniature);
    console.log(check1, check2, check3, check4)
    checkButton();
});

picture.addEventListener("input", function () {
    check3 = check(picture);
    checkButton();
});

paragraph1.addEventListener("input", function () {
    check4 = check(paragraph1);
    checkButton();
});

paragraph2.addEventListener("input", function () {
    checkGreen(paragraph2);
});
paragraph3.addEventListener("input", function () {
    checkGreen(paragraph3);
});
paragraph4.addEventListener("input", function () {
    checkGreen(paragraph4);
});
paragraph5.addEventListener("input", function () {
    checkGreen(paragraph5);
});
paragraph6.addEventListener("input", function () {
    checkGreen(paragraph6);
});
paragraph7.addEventListener("input", function () {
    checkGreen(paragraph7);
});
paragraph8.addEventListener("input", function () {
    checkGreen(paragraph8);
}); 
paragraph9.addEventListener("input", function () {
    checkGreen(paragraph9);
});

check1 = check(title);
check2 = check(miniature);
check3 = check(picture);
check4 = check(paragraph1);
checkGreen(paragraph2);
checkGreen(paragraph3);
checkGreen(paragraph4);
checkGreen(paragraph5);
checkGreen(paragraph6);
checkGreen(paragraph7);
checkGreen(paragraph8);
checkGreen(paragraph9);
checkButton();





























