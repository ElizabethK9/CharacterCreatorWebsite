// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
  $(document).ready(function() {
    $('#sidebar').hover(function() {
      $(this).addClass('expanded');
    }, function() {
      $(this).removeClass('expanded');
    });
  });
</script>
