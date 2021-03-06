/**
 * Galleria Bongiozzo Theme 2012-04-04
 * http://galleria.io
 *
 * Licensed under the MIT license
 * https://raw.github.com/aino/galleria/master/LICENSE
 *
 */

(function($) {

/*global jQuery, Galleria */

Galleria.addTheme({
    name: 'bongiozzo',
    author: 'Bongiozzo',
    css: 'galleria.bongiozzo.css',
    defaults: {
        transition: 'slide',
        thumbCrop:  'height',

        // set this to false if you want to show the caption all the time:
        _toggleInfo: true
    },
    init: function(options) {

        Galleria.requires(1.25, 'This version of Bongiozzo theme requires Galleria 1.2.5 or later');

        // add some elements
        this.addElement('info-link', 'info-close', 'closeBG', 'socialBG');
        this.append({
            'info' : ['info-link','info-close']
        });

        // cache some stuff
        var info = this.$('info-link,info-close,info-text'),
            touch = Galleria.TOUCH,
            click = touch ? 'touchstart' : 'click';

        this.append({ 'stage': ['closeBG', 'socialBG'] });

        this.$('socialBG').html('<div id="div-fblike"></div><div id="div-twitter"></div>');
        
        this.$('closeBG').bind("click", function (e) { window.location = "/"; });

        // show loader & counter with opacity
        this.$('loader,counter').show().css('opacity', 0.4);

        // some stuff for non-touch browsers
        if (! touch ) {
            this.addIdleState(this.get('image-nav-left'), { left:-50 });
            this.addIdleState(this.get('image-nav-right'), { right:-50 });
            this.addIdleState(this.get('counter'), { opacity:0 });
            this.addIdleState(this.get('info'), { opacity: 0 });
            this.addIdleState(this.get('closeBG'), { opacity: 0 });
        }

        // toggle info
        if ( options._toggleInfo === true ) {
            info.bind( click, function() {
                info.toggle();
            });
        } else {
            info.show();
            this.$('info-link, info-close').hide();
        }
        info.toggle();

        // bind some stuff
        this.bind('thumbnail', function(e) {

            if (! touch ) {
                // fade thumbnails
                $(e.thumbTarget).css('opacity', 0.6).parent().hover(function() {
                    $(this).not('.active').children().stop().fadeTo(100, 1);
                }, function() {
                    $(this).not('.active').children().stop().fadeTo(400, 0.6);
                });

                if ( e.index === this.getIndex() ) {
                    $(e.thumbTarget).css('opacity',1);
                }
            } else {
                $(e.thumbTarget).css('opacity', this.getIndex() ? 1 : 0.6);
            }
        });

        this.bind('loadstart', function(e) {
            if (!e.cached) {
                this.$('loader').show().fadeTo(200, 0.4);
            }

            this.$('info').toggle( this.hasInfo() );

            $(e.thumbTarget).css('opacity',1).parent().siblings().children().css('opacity', 0.6);
        });

        this.bind('loadfinish', function(e) {
            this.$('loader').fadeOut(200);
        });

  }
});

}(jQuery));
