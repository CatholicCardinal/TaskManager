const dropdownBtn = document.getElementById("nav-btn");
const dropdownList = document.getElementById("nav-dropdown");

dropdownBtn.addEventListener("click", function () {
    if (dropdownList.style.display === "none") {
        dropdownList.style.display = "block";
    } else {
        dropdownList.style.display = "none";
    }
});

document.addEventListener('click', (event) => {
    const isClickInside = dropdownList.contains(event.target);
    const isClickInsideBtn = dropdownBtn.contains(event.target);
    if (dropdownList.style.display == "block" && !isClickInside && !isClickInsideBtn) {
        dropdownList.style.display = "none";
    }
});

