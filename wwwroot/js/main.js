$(document).ready(function(){
    if (document.getElementById("nav__itemssign"))
        document.getElementById("nav__itemssign").addEventListener("click",function(){
            document.querySelector(".modal").style.display = "flex"
        })
    document.getElementById("btn-out").addEventListener("click",function(){
        document.querySelector(".modal").style.display = 'none'
    })
    if (document.getElementById("nav__itemslogin"))
    document.getElementById("nav__itemslogin").addEventListener("click",function(){
        document.querySelector(".modal1").style.display = "flex"
    })
    document.getElementById("btn-out1").addEventListener("click",function(){
        document.querySelector(".modal1").style.display = "none"
    })
    document.getElementById("btn-sign").addEventListener("click",function(){
        document.querySelector(".modal1").style.display = "none"
        document.querySelector(".modal").style.display = "flex"
    })
    document.getElementById("btn-login").addEventListener("click",function(){
        document.querySelector(".modal").style.display = "none"
        document.querySelector(".modal1").style.display = "flex"
    })
    document.querySelector('.btn--cart').addEventListener("click",function(){
        window.location='/cart'
    });
    // document.querySelector('.home__product-items').addEventListener("click",function(){
    //     window.location='details.html'
    // });
    // $('.home__product-items').click(function(e) {
    //     window.location='/detail';
    // });
    // document.querySelector('.search__list-history').onmousedown=function(e){
    //     e.preventDefault();
    // };
    document.querySelector('.heading__main').addEventListener("click",function(){
        window.location='index.html'
    });
    $('.fa-plus').click(function(e) {
        var inputEle = $(this).parent().siblings('input');
        var quantity = inputEle.val() || 1;
        inputEle.val(++quantity);
    });
    $('.fa-minus').click(function(e) {
        var inputEle = $(this).parent().siblings('input');
        var quantity = inputEle.val() || 1;
        if (quantity == 1 )
            return;
        inputEle.val(--quantity);
    });
    var listStars = $('.stars-click').children();
    for (var i=0; i<listStars.length; i++) {
        $(listStars[i]).click(function(e) {
            $('#userRate').val($(this).prevAll().length + 1);
            $(this).prevAll().addClass('checked');
            $(this).addClass('checked');
            $(this).nextAll().removeClass('checked');
        });   
    }

});
    


