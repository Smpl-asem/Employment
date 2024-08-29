/**  
 *  Form Wizard  
 */  
'use strict';  

(function () {  
  const wizardPropertyListing = document.querySelector('.wizard-vertical-icons-example');  

  if (wizardPropertyListing !== null) {  
    const wizardPropertyListingForm = wizardPropertyListing.querySelector('#fomame');  
    
    const wizardPropertyListingFormSteps = [  
      wizardPropertyListingForm.querySelector('#personal-data'),  
      wizardPropertyListingForm.querySelector('#family-data'),  
      wizardPropertyListingForm.querySelector('#study-data'),  
      wizardPropertyListingForm.querySelector('#abilities'),  
      wizardPropertyListingForm.querySelector('#workHistory')  
    ];  

    const wizardPropertyListingNext = [].slice.call(wizardPropertyListingForm.querySelectorAll('.btn-next'));  
    const wizardPropertyListingPrev = [].slice.call(wizardPropertyListingForm.querySelectorAll('.btn-prev'));  
    const wizardIconsVerticalBtnSubmit = wizardPropertyListing.querySelector('.btn-submit');  

    const validationStepper = new Stepper(wizardPropertyListing, { linear: true });  

    const validateStep = (step) => {  
      if (!step) {  
        console.error('مرحله معتبر نمی‌باشد.');  
        return false; // اگر مرحله صحیح نباشد، اعتبارسنجی نامعتبر است  
      }  

      const inputs = step.querySelectorAll('input[required]');  
      let isValid = true;  

      inputs.forEach(input => {  
        if (!input.value.trim()) {  
          isValid = false;  
          input.classList.add('is-invalid');   
        } else {  
          input.classList.remove('is-invalid');   
        }  
      });  

      return isValid;  
    };  

    wizardPropertyListingNext.forEach((button) => {  
      button.addEventListener('click', (event) => {  
        const currentStep = button.closest('.step2');   
        
        if (validateStep(currentStep)) {  
          validationStepper.next();   
        } else {  
          alert('لطفا تمام فیلدهای اجباری را پر کنید.');  
        }  
      });  
    });  

    wizardPropertyListingPrev.forEach((button) => {  
      button.addEventListener('click', () => {  
        validationStepper.previous();   
      });  
    });  

    if (wizardIconsVerticalBtnSubmit) {  
      wizardIconsVerticalBtnSubmit.addEventListener('click', event => {  
        const form = wizardPropertyListingForm;  
        
        const allInputsValid = [...wizardPropertyListingFormSteps].every(step => validateStep(step));  
        
        if (allInputsValid) {  
          form.submit();   
        } else {  
          alert('لطفا تمام فیلدهای اجباری را پر کنید.');  
          event.preventDefault();   
        }  
      });  
    }  
  }  
})();