(function () {
    let deleteBtn = document.getElementById("deleteBtn");
    let confirmedDeleteBtn = document.getElementById("confirmedDelete");

    deleteBtn.addEventListener("click", function () {
        let confirmation = confirm("Please confirm that you want to delete your account!");

        if (confirmation) {
            confirmedDeleteBtn.click();
        }
    })
})()