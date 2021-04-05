using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class ConfirmationBase : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        public void SubmitForm()
        {
            ModalInstance.CloseAsync(ModalResult.Ok($"Form was submitted successfully."));
        }

        public void Cancel()
        {
            ModalInstance.CancelAsync();
        }
    }
}