$(document).ready(function(){
    // document.getElementById("btn-out1").addEventListener("click",function(){
    //     document.querySelector(".modal1").style.display = "none"
    // })
    document.getElementById("btn-sign").addEventListener("click",function(){
        document.querySelector(".modal1").style.display = "none"
        document.querySelector(".modal").style.display = "flex"
    })
    document.getElementById("btn-login").addEventListener("click",function(){
        console.log("Abc")
        document.querySelector(".modal").style.display = "none"
        document.querySelector(".modal1").style.display = "flex"
    })
    // document.querySelector('.home__product-items').addEventListener("click",function(){
    //     window.location='details.html'
    // });
    // $('.home__product-items').click(function(e) {
    //     window.location='/detail';
    // });
    $('.fa-plus').click(function(e) {
        var inputEle = $(this).parent().siblings('input');
        var quantity = inputEle.val() || 1;
        inputEle.val(++quantity);
    });
    $('.fa-minus').click(function(e) {
        var inputEle = $(this).parent().siblings('input');
        var quantity = inputEle.val() || 1;
        if (quantity == 0 )
            return;
        inputEle.val(--quantity);
    });
});
    