import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-aaa-согласие', 'Unit | Serializer | i-i-s-aaa-согласие', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-aaa-согласие',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'model:i-i-s-aaa-согласие',
    'model:i-i-s-aaa-сотрудники',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
