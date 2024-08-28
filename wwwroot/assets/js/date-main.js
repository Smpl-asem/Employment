/**
 *  Form Wizard
 */

'use strict';

(function () {
  // Init custom option check
  const flatpickrDate = document.querySelector('#flatpickr-date')
  // Date
  if (flatpickrDate) {
    flatpickrDate.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const study1Date = document.querySelector('#study1-date')
  // Date
  if (study1Date) {
    study1Date.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const study2Date = document.querySelector('#study2-date')
  // Date
  if (study2Date) {
    study2Date.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const exJobstart = document.querySelector('#exJob-start')
  // Date
  if (exJobstart) {
    exJobstart.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const exJobend = document.querySelector('#exJob-end')
  // Date
  if (exJobend) {
    exJobend.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const exJob2start = document.querySelector('#exJob2-start')
  // Date
  if (exJob2start) {
    exJob2start.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const exJob2end = document.querySelector('#exJob2-end')
  // Date
  if (exJob2end) {
    exJob2end.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  const jobstart = document.querySelector('#jobstart')
  // Date
  if (jobstart) {
    jobstart.flatpickr({
      monthSelectorType: 'static',
      locale: 'fa',
      altInput: true,
      altFormat: 'Y/m/d',
      disableMobile: true
    });
  }
  })();
