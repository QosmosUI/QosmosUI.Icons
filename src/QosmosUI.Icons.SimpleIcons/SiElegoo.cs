// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiElegoo : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12.686 7.479c.54.829 1.032 1.665 1.476 2.505.64-1.217 1.849-2.086 3.328-2.086 2.217 0 3.826 1.954 3.826 4.102 0 2.149-1.609 4.102-3.826 4.102-.656 0-1.26-.171-1.784-.467l-.001-.001c-.635-.36-1.153-.905-1.509-1.553-.484-.804-.725-1.706-.991-2.657-.598-2.134-1.252-3.773-3.194-4.988-1.001-.626-2.196-.985-3.501-.985C2.815 5.451 0 8.323 0 12c0 3.727 2.761 6.549 6.51 6.549 1.955 0 3.639-.766 4.805-2.027-.543-.83-1.034-1.664-1.477-2.505-.641 1.217-1.849 2.085-3.328 2.085-2.218 0-3.827-1.953-3.827-4.102 0-2.148 1.609-4.102 3.827-4.102.655 0 1.26.171 1.783.469h.001c.635.36 1.154.904 1.509 1.553.574.951.807 2.041 1.144 3.188.555 1.89 1.285 3.339 3.002 4.432 1.008.642 2.217 1.009 3.541 1.009 3.694 0 6.51-2.872 6.51-6.549 0-3.727-2.76-6.549-6.51-6.549-1.954 0-3.64.766-4.804 2.028Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
