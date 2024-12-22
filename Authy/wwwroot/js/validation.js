document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById("loginForm");
    const passwordInput = document.getElementById("password");
    const showPasswordCheckbox = document.getElementById("showPassword");
    const submitButton = document.getElementById("submitButton");

    form.addEventListener("input", () => {
        const isValid = form.checkValidity();
        submitButton.disabled = !isValid;
    });

    showPasswordCheckbox.addEventListener("change", () => {
        passwordInput.type = showPasswordCheckbox.checked ? "text" : "password";
    });
});
