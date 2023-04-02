$(document).ready(function () {
   $(".dws-form").on("click", ".tab", function () {

      $(".dws-form").find(".active").removeClass("active");

      $(this).addClass("active");
      $(".tab-form").eq($(this).index()).addClass("active");

      function showSuccess(input) {
         const formControl = input.parentElement;
         formControl.className = "form-control success";
      }
      //checkEmail
      (input) => {
         const re = /^[a-zA-Z0-9_.]+@[a-z]+\.[a-z]+$/;
         if (re.test(input.value.trim())) {
            showSuccess(input);
         } else {
             showError(input, "Uncorrect");
         }
      }
   });
});