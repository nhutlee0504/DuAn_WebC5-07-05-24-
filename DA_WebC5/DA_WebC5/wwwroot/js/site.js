// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function() {
  function isElementInViewport(el) {
    var rect = el.getBoundingClientRect();
    return (
      rect.top >= 0 &&
      rect.left >= 0 &&
      rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
      rect.right <= (window.innerWidth || document.documentElement.clientWidth)
    );
  }

  function onScroll() {
    var elementsLeft = document.querySelectorAll('.slide-in-left');
    var elementsRight = document.querySelectorAll('.slide-in-right');

    elementsLeft.forEach(function(el) {
      if (isElementInViewport(el)) {
        el.classList.add('active');
      }
    });

    elementsRight.forEach(function(el) {
      if (isElementInViewport(el)) {
        el.classList.add('active');
      }
    });
  }

  window.addEventListener('scroll', onScroll);
  onScroll(); // Kiểm tra ngay khi tải trang
});
