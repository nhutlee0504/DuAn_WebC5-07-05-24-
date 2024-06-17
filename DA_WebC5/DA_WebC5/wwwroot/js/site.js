// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById('profile-img').addEventListener('click', function () {
    var userInfo = document.getElementById('user-info');
    if (userInfo.classList.contains('show')) {
        userInfo.classList.remove('show');
    } else {
        userInfo.classList.add('show');
    }
});
