
let findIcon = document.querySelector('.find-icon');
let burgerMenu = document.querySelector('.burger-menu-icon');
let backIcon = document.querySelector('.back-icon');
let nextIcon = document.querySelector('.next-icon');

//hover do find
findIcon.addEventListener('mouseover', function () {
    let find = document.querySelector('.find');
    find.style.visibility = 'visible';

})
findIcon.addEventListener('mouseout', function () {
    let find = document.querySelector('.find');
    find.style.visibility = 'hidden';

})

findIcon.addEventListener('click', function () {
    let findOption = document.querySelector('.find-option');
    let showAll = document.querySelector('.show-all-option');
    if (findOption.style.display === 'block') { findOption.style.display = 'none'; findIcon.style.color = 'dimgray'; }
    else { findOption.style.display = 'block'; findIcon.style.color = 'white'; showAll.style.display = 'none'; burgerMenu.style.color = 'dimgray'; }
})

//hover i otwieranie listy wszystkich bajek
burgerMenu.addEventListener('mouseover', function () {
    let showAll = document.querySelector('.show-all');
    showAll.style.visibility = 'visible';

})
burgerMenu.addEventListener('mouseout', function () {
    let showAll = document.querySelector('.show-all');
    showAll.style.visibility = 'hidden';

})
burgerMenu.addEventListener('click', function () {
    let showAll = document.querySelector('.show-all-option');
    let findOption = document.querySelector('.find-option');
    if (showAll.style.display === 'block') { showAll.style.display = 'none'; burgerMenu.style.color = 'dimgray'; }
    else { showAll.style.display = 'block'; burgerMenu.style.color = 'white'; findOption.style.display = 'none'; findIcon.style.color = 'dimgray'; }
})

//hover do back menu
backIcon.addEventListener('mouseover', function () {
    let find = document.querySelector('.back');
    find.style.visibility = 'visible';

})
backIcon.addEventListener('mouseout', function () {
    let find = document.querySelector('.back');
    find.style.visibility = 'hidden';

})

//hover do strzałki w prawo
nextIcon.addEventListener('mouseover', function () {
    let find = document.querySelector('.next');
    find.style.visibility = 'visible';

})
nextIcon.addEventListener('mouseout', function () {
    let find = document.querySelector('.next');
    find.style.visibility = 'hidden';

})


