using Microsoft.AspNetCore.Components;

namespace Lava
{
    public class LavaBaseComponent : ComponentBase
    {
        private bool _isFocused = false;
        [Parameter]
        public bool IsFocused
        {
            get => _isFocused;
            set
            {
                if (_isFocused == value)
                    return;

                _isFocused = value;
                OnIsFocusedChanged();
                IsFocusedChanged.InvokeAsync(value);
            }
        }
        [Parameter]
        public EventCallback<bool> IsFocusedChanged { get; set; }

        protected virtual void OnIsFocusedChanged()
        {
            // This part could be overridden in child classes
        }
    }
}
