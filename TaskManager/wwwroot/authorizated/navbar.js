const dropdownBtn = document.getElementById("nav-btn");
const dropdownList = document.getElementById("nav-dropdown");

document.addEventListener('click', (event) => {
    const isClickInside = dropdownList.contains(event.target);
    const isClickInsideBtn = dropdownBtn.contains(event.target);
    if (dropdownList.style.display == "block" && !isClickInside && !isClickInsideBtn) {
        dropdownList.style.display = "none";
    }
});

dropdownBtn.addEventListener("click", function () {
    if (dropdownList.style.display != "block") {
        dropdownList.style.display = "block";
    } else {
        dropdownList.style.display = "none";
    }
});

dropdownBtn.addEventListener('click', function () {
    // добавляем или удаляем класс "active" в зависимости от того, открыт ли выпадающий список
    if (dropdownList.classList.contains('active')) {
        dropdownList.classList.remove('active');
        dropdownBtn.classList.remove('active');
    } else {
        dropdownList.classList.add('active');
        dropdownBtn.classList.add('active');
    }
});

