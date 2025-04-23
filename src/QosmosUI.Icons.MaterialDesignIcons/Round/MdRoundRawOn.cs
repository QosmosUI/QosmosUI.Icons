// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRawOn : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "rect");
		builder.AddAttribute(15, "fill", "none");
		builder.AddAttribute(16, "height", "24");
		builder.AddAttribute(17, "width", "24");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "g");
		builder.OpenElement(20, "path");
		builder.AddAttribute(21, "d", "M6.5,9H4c-0.55,0-1,0.45-1,1v4.31C3,14.69,3.31,15,3.69,15h0.11c0.38,0,0.69-0.31,0.69-0.69V13h1.1l0.72,1.59 C6.43,14.84,6.68,15,6.95,15h0c0.5,0,0.83-0.51,0.64-0.97L7.1,12.9C7.6,12.6,8,12.1,8,11.5v-1C8,9.68,7.32,9,6.5,9z M6.5,11.5h-2 v-1h2V11.5z");
		builder.CloseElement();
		builder.OpenElement(22, "path");
		builder.AddAttribute(23, "d", "M11.5,9c-0.73,0-1.37,0.5-1.55,1.21L8.98,14.1C8.86,14.56,9.21,15,9.68,15h0c0.33,0,0.62-0.23,0.7-0.55l0.24-0.95h1.75 l0.23,0.95c0.08,0.32,0.37,0.55,0.71,0.55h0c0.47,0,0.82-0.44,0.71-0.9l-0.97-3.88C12.87,9.5,12.23,9,11.5,9L11.5,9z M11,12 l0.25-1h0.5L12,12H11z");
		builder.CloseElement();
		builder.OpenElement(24, "path");
		builder.AddAttribute(25, "d", "M19.84,9.55L19.24,12l-0.56-2.26C18.58,9.3,18.19,9,17.74,9l0,0c-0.45,0-0.84,0.3-0.94,0.74L16.24,12l-0.6-2.45 C15.56,9.23,15.27,9,14.93,9h0c-0.47,0-0.82,0.44-0.71,0.9l1.09,4.38C15.43,14.7,15.81,15,16.24,15l0,0c0.43,0,0.81-0.3,0.92-0.72 l0.58-2.32l0.58,2.32C18.43,14.7,18.81,15,19.24,15l0,0c0.43,0,0.81-0.3,0.92-0.72l1.09-4.38C21.37,9.44,21.02,9,20.55,9h0 C20.21,9,19.92,9.23,19.84,9.55z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
