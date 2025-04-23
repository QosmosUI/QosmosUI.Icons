// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiOperaLine : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14.7665 19.5091C17.8219 18.3834 20.001 15.4462 20.001 12C20.001 8.55381 17.8219 5.61656 14.7665 4.4909C16.7122 5.97596 18.001 8.93354 18.001 12C18.001 15.0665 16.7122 18.024 14.7665 19.5091ZM9.23543 4.4909C6.18001 5.61656 4.00098 8.55381 4.00098 12C4.00098 15.4462 6.18001 18.3834 9.23543 19.5091C7.28979 18.024 6.00098 15.0665 6.00098 12C6.00098 8.93354 7.28979 5.97596 9.23543 4.4909ZM12.001 22C6.47813 22 2.00098 17.5228 2.00098 12C2.00098 6.47715 6.47813 2 12.001 2C17.5238 2 22.001 6.47715 22.001 12C22.001 17.5228 17.5238 22 12.001 22ZM12.001 18.5C14.001 18.5 16.001 15.4667 16.001 12C16.001 8.53333 14.001 5.5 12.001 5.5C10.001 5.5 8.00098 8.53333 8.00098 12C8.00098 15.4667 10.001 18.5 12.001 18.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
