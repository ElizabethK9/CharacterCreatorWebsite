// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// jQuery for sidebar hover effect
$(document).ready(function () {
    $('#sidebar').hover(function () {
        $(this).addClass('expanded');
    }, function () {
        $(this).removeClass('expanded');
    });
});

// JavaScript for theme toggle
const toggleButton = document.getElementById('theme-toggle');
const currentTheme = localStorage.getItem('theme') || 'light';

document.documentElement.setAttribute('data-theme', currentTheme);

toggleButton.addEventListener('click', () => {
    const theme = document.documentElement.getAttribute('data-theme') === 'dark' ? 'light' : 'dark';
    document.documentElement.setAttribute('data-theme', theme);
    localStorage.setItem('theme', theme);
});


