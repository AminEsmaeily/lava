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

        private bool _enabled = true;
        [Parameter]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                if (_enabled == value)
                    return;
                _enabled = value;
                EnabledChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public EventCallback<bool> EnabledChanged { get; set; }

        private bool _readOnly = false;
        [Parameter]
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                if (value == _readOnly)
                    return;

                _readOnly = value;
                ReadOnlyChanged.InvokeAsync(value);
            }
        }

        [Parameter]
        public EventCallback<bool> ReadOnlyChanged { get; set; }
    }
}
