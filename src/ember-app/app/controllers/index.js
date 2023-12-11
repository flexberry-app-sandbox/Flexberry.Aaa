import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.aaa.caption'),
          title: i18n.t('forms.application.sitemap.aaa.title'),
          children: [{
            link: 'i-i-s-aaa-согласие-l',
            caption: i18n.t('forms.application.sitemap.aaa.i-i-s-aaa-согласие-l.caption'),
            title: i18n.t('forms.application.sitemap.aaa.i-i-s-aaa-согласие-l.title'),
            icon: 'paperclip',
            children: null
          }]
        }
      ]
    };
  }),
})