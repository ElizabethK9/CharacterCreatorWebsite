// jQuery for sidebar hover effect
$(document).ready(function () {
    $('#sidebar').hover(function () {
        $(this).addClass('expanded');
    }, function () {
        $(this).removeClass('expanded');
    });
});

document.addEventListener("DOMContentLoaded", function () {
    const root = document.documentElement;

    // Get Light and Dark Mode buttons
    const lightModeButton = document.getElementById("light-mode");
    const darkModeButton = document.getElementById("dark-mode");

    // Check and apply stored theme preference
    const storedTheme = localStorage.getItem("theme") || "light";
    root.setAttribute("data-theme", storedTheme);

    // Disable the current theme's button
    const updateButtonStates = () => {
        lightModeButton.disabled = root.getAttribute("data-theme") === "light";
        darkModeButton.disabled = root.getAttribute("data-theme") === "dark";
    };

    updateButtonStates(); // Set initial button states

    // Event listener for Light Mode button
    lightModeButton?.addEventListener("click", () => {
        root.setAttribute("data-theme", "light");
        localStorage.setItem("theme", "light");
        updateButtonStates();
    });

    // Event listener for Dark Mode button
    darkModeButton?.addEventListener("click", () => {
        root.setAttribute("data-theme", "dark");
        localStorage.setItem("theme", "dark");
        updateButtonStates();
    });
});


