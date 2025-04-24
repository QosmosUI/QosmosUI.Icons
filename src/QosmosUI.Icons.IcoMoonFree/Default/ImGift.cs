// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImGift : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 16 16";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12.055 5c0.283-0.201 0.555-0.425 0.804-0.674 0.522-0.522 0.871-1.164 0.983-1.808 0.123-0.706-0.057-1.362-0.494-1.798-0.348-0.348-0.82-0.533-1.365-0.533-0.775 0-1.593 0.372-2.242 1.021-1.039 1.039-1.644 2.472-1.97 3.496-0.241-1.028-0.722-2.416-1.657-3.351-0.501-0.501-1.142-0.759-1.748-0.759-0.495 0-0.965 0.172-1.317 0.523-0.781 0.781-0.675 2.153 0.236 3.064 0.325 0.325 0.705 0.595 1.105 0.819h-3.391v4h1v7h12v-7h1v-4h-2.945zM10.536 2.003c0.433-0.433 0.974-0.692 1.446-0.692 0.167 0 0.402 0.035 0.57 0.203 0.407 0.407 0.178 1.349-0.489 2.016-0.687 0.687-1.61 1.159-2.413 1.47h-0.792c0.29-0.899 0.813-2.132 1.678-2.997zM3.655 2.514c-0.011-0.143-0.001-0.41 0.191-0.601 0.16-0.16 0.372-0.194 0.521-0.194v0c0.332 0 0.679 0.157 0.952 0.429 0.529 0.529 0.965 1.371 1.26 2.436 0.008 0.029 0.016 0.057 0.023 0.086-0.028-0.008-0.057-0.015-0.086-0.023-1.064-0.295-1.906-0.731-2.436-1.26-0.247-0.247-0.403-0.565-0.426-0.872zM7 15h-4v-6.5h4v6.5zM7 8h-5v-2h5v2zM13 15h-4v-6.5h4v6.5zM14 8h-5v-2h5v2z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
