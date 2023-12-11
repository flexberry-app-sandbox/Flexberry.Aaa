import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  номер: DS.attr('number'),
  сотрудники: DS.hasMany('i-i-s-aaa-сотрудники', { inverse: 'согласие', async: false })
});

export let ValidationRules = {
  номер: {
    descriptionKey: 'models.i-i-s-aaa-согласие.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  сотрудники: {
    descriptionKey: 'models.i-i-s-aaa-согласие.validations.сотрудники.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('СогласиеE', 'i-i-s-aaa-согласие', {
    номер: attr('Номер', { index: 0 }),
    сотрудники: hasMany('i-i-s-aaa-сотрудники', 'Сотрудники', {
      номер: attr('Номер', { index: 0 }),
      фио: attr('Фио', { index: 1 }),
      телефон: attr('Телефон', { index: 2 })
    })
  });

  modelClass.defineProjection('СогласиеL', 'i-i-s-aaa-согласие', {
    номер: attr('Номер', { index: 0 })
  });
};
