//trochę się tu za dużo powtarzam, wypadałoby posprzątać...


let editButton = document.querySelector(".edit-button");
let deleteButton = document.querySelector(".delete-button");
let edit = document.querySelector(".edit");
let del=document.querySelector(".delete");

let leftArrows = document.querySelectorAll(".ti-arrow-narrow-left")
let rightArrows = document.querySelectorAll(".ti-arrow-narrow-right");
let upArrows = document.querySelectorAll(".ti-arrow-narrow-up");
let downArrows = document.querySelectorAll(".ti-arrow-narrow-down")


//zwraca ilość bajek w każdym rzędzie
function windowElements() {
    let width = window.innerWidth;
    let el = Math.floor((width - 825) / 400) + 2;
    return el;
}
//wybiera inputa o podanym numerze
function chooseInput(inputNumber) {
    inputname = 'input' + inputNumber;
    return input = document.getElementById(inputname);
}

//chowa niepotrzebne strzałki dla każdych bajek
function hideShowArrows() {
    tales = document.querySelectorAll(".tale");
    elements = windowElements();
    for (let i = 0; i < tales.length; i++) {

        if (i == 0) {
            tales[i].querySelector(".left").style.visibility = "hidden";
        }
        else {
            tales[i].querySelector(".left").style.visibility = "visible";
        }
        if (i == tales.length - 1) {
            tales[i].querySelector(".right").style.visibility = "hidden";
        }
        else {
            tales[i].querySelector(".right").style.visibility = "visible"
        }
        if (i < elements) {
            tales[i].querySelector(".up").style.visibility = "hidden";
        }
        else {
            tales[i].querySelector(".up").style.visibility = "visible";
        }
        if (i > tales.length - elements - 1) {
            tales[i].querySelector(".down").style.visibility = "hidden";
        }
        else {
            tales[i].querySelector(".down").style.visibility = "visible";
        }
    }
}


//rozwija liste bajek w menu na górze
editButton.addEventListener('click', function () {
    if (edit.style.visibility !== "visible") {
        edit.style.visibility = "visible";
        del.style.visibility = "hidden";
    }
    else {
        edit.style.visibility = "hidden";
    }
})

//rozwija liste bajek dla "usuń" w menu na górze
deleteButton.addEventListener('click', function () {
    if (del.style.visibility !== "visible") {
        del.style.visibility = "visible";
        edit.style.visibility = "hidden";
    }
    else {
        del.style.visibility = "hidden";
    }
})

//obsługa prawych strzałek 
rightArrows.forEach(arrow => {
    arrow.addEventListener('click', function () {
        let tale = arrow.parentNode.parentNode.parentNode.parentNode.parentNode;
        let nextTale = tale.nextElementSibling;
        nextTale.insertAdjacentElement('afterend', tale);
        console.log(tale.id);
        let taleInput = chooseInput(tale.id);
        taleInput.value=parseInt(taleInput.value)+1;
        let nextTaleInput = chooseInput(nextTale.id);
        nextTaleInput.value = parseInt(nextTaleInput.value) - 1;
        hideShowArrows()
    })
});

//obsługa lewych strzałek
leftArrows.forEach(arrow => {
    arrow.addEventListener('click', function () {
        let tale = arrow.parentNode.parentNode.parentNode.parentNode.parentNode;
        let prevTale = tale.previousElementSibling;
        tale.insertAdjacentElement('afterend', prevTale);
        let taleInput = chooseInput(tale.id);
        taleInput.value = parseInt(taleInput.value) - 1;
        let prevTaleInput = chooseInput(prevTale.id);
        prevTaleInput.value = parseInt(prevTaleInput.value) + 1;
        hideShowArrows()
    })
});

//obsługa strzałek w górę
upArrows.forEach(arrow => {
    arrow.addEventListener('click', function () {
        let tale = arrow.parentNode.parentNode.parentNode.parentNode.parentNode;
        let width = window.innerWidth;
        let prevTale = tale.previousElementSibling;
        let prevTaleInput = chooseInput(prevTale.id);
        prevTaleInput.value = parseInt(prevTaleInput.value) + 1;
        let times = Math.floor((width - 825) / 400);
        if (times +1 > 0) {
            for (let i = 0; i < times+1; i += 1) {
                prevTale = prevTale.previousElementSibling;
                prevTaleInput = chooseInput(prevTale.id);
                prevTaleInput.value = parseInt(prevTaleInput.value) + 1;
            }
        }
        let taleInput = chooseInput(tale.id);
        taleInput.value = parseInt(taleInput.value) - times-2;
        tale.parentNode.insertBefore(tale, prevTale);
        hideShowArrows()
    })
});

//obsługa strzałek w dół
downArrows.forEach(arrow => {
    arrow.addEventListener('click', function () {
        let tale = arrow.parentNode.parentNode.parentNode.parentNode.parentNode;
        let width = window.innerWidth;
        let nextTale = tale.nextElementSibling;
        let nextTaleInput = chooseInput(nextTale.id);
        nextTaleInput.value = parseInt(nextTaleInput.value) - 1;
        let times = Math.floor((width - 825) / 400);
        if (times+1 > 0) {
            for (let i = 0; i < times+1; i += 1) {
                nextTale = nextTale.nextElementSibling;
                nextTaleInput = chooseInput(nextTale.id);
                nextTaleInput.value = parseInt(nextTaleInput.value) - 1;
            }
        }
        tale.parentNode.insertBefore(tale, nextTale.nextElementSibling);
        let taleInput = chooseInput(tale.id);
        taleInput.value = parseInt(taleInput.value) + times + 2;
        hideShowArrows();
    })
});



console.log("fwfwfew");
hideShowArrows();
chooseInput(3);


