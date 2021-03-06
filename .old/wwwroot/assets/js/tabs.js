/*
 * EZ Tabs
 * by Razvan Zamfir
 */
! function(i) {
    i.fn.eztabs = function(n) {
      var a = i.extend({
        tabsList: ".ez_tabs",
        boxContainer: ".ez_content",
        animation: "none",
        animationTime: 500,
        fullWidthTabs: !0
      }, n);
      return this.each(function() {
        var n = this,
          t = a.tabsList,
          e = a.boxContainer;
        a.fullWidthTabs === !0 && i(t).addClass("fullwidth");
        var s = i(n).find(e).children();
        i(s).hide(), i(s[0]).show();
        var o = i(n).find(t).children("li");
        i(o[0]).addClass("active"), i(o).each(function(n) {
          i(this).on("click", function() {
            i(this).addClass("active"), i(o).not(this).removeClass("active");
            var t = i(s[n]);
            return "none" === a.animation ? (i(s).hide(), i(t).show()) : "slideUpDown" === a.animation ? (i(s).slideUp(a.animationTime), i(t).slideDown(a.animationTime)) : "slideLeftRight" === a.animation && (i(e).css("overflow", "hidden"), i(s).css({
              width: "100%",
              display: "none"
            }), i(s).animate({
              marginLeft: "-110%"
            }, a.animationTime), i(t).css("display", "block").animate({
              marginLeft: "0"
            }, a.animationTime)), !1
          })
        })
      })
    }
  }(jQuery);
  
  $(function() {
    $('.tabset').eztabs({
      animation: 'slideUpDown',
      animationTime: 200
    });
  });