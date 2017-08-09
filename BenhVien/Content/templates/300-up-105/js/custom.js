// Custom Script
// Developed by: Samson.Onna
// CopyRights : http://webthemez.com
var customScripts = {
    profile: function () {
        var portfolio = $('#portfolio');
        var items = $('.items', portfolio);
        var filters = $('.filters li a', portfolio);

        filters.click(function () {
            var el = $(this);
            filters.removeClass('active');
            el.addClass('active');
            var selector = el.attr('data-filter');
            items.isotope({ filter: selector });
            return false;
        });
    },

    onePageNav: function () {
        $('#mainNav').onePageNav({
            currentClass: 'active',
            changeHash: false,
            scrollSpeed: 950,
            scrollThreshold: 0.2,
            filter: '',
            easing: 'swing',
            begin: function () {
                //I get fired when the animation is starting
            },
            end: function () {
                //I get fired when the animation is ending
                if (!$('#main-nav ul li:first-child').hasClass('active')) {
                    $('.header').addClass('addBg');
                } else {
                    $('.header').removeClass('addBg');
                }
            },
            scrollChange: function ($currentListItem) {
                //I get fired when you enter a section and I pass the list item of the section
                if (!$('#main-nav ul li:first-child').hasClass('active')) {
                    $('.header').addClass('addBg');
                } else {
                    $('.header').removeClass('addBg');
                }
            }
        });

        $("a[href='#top']").click(function () {
            $("html, body").animate({ scrollTop: 0 }, "slow");
            return false;
        });
        $("a[href='#basics']").click(function () {
            $("html, body").animate({ scrollTop: $('#services').offset().top - 75 }, "slow");
            return false;
        });
    },

    bannerHeight: function () {
        var bHeight = $(".banner-container").height();
        $('#da-slider').height(bHeight);
        $(window).resize(function () {
            var bHeight = $(".banner-container").height();
            $('#da-slider').height(bHeight);
        });
    },

    init: function () {
        customScripts.onePageNav();
        customScripts.profile();

        // customScripts.fitText();
        customScripts.bannerHeight();
    }
}
$('document').ready(function () {
    customScripts.init();
});