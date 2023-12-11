import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-aaa-согласие-l');
  this.route('i-i-s-aaa-согласие-e',
  { path: 'i-i-s-aaa-согласие-e/:id' });
  this.route('i-i-s-aaa-согласие-e.new',
  { path: 'i-i-s-aaa-согласие-e/new' });
});

export default Router;
