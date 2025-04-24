// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiRemoteControlLine : ComponentBase
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
		builder.AddAttribute(14, "d", "M17.0001 12C17.5524 12 18.0001 12.4477 18.0001 13V22H16.0001V14H8.00015V22H6.00015V13C6.00015 12.4477 6.44786 12 7.00015 12H17.0001ZM12.0001 16V18H10.0001V16H12.0001ZM12.0001 6C14.3491 6 16.3827 7.34978 17.3678 9.31602L15.5787 10.2108C14.922 8.89991 13.5662 8 12.0001 8C10.4341 8 9.07833 8.89991 8.42163 10.2108L6.63247 9.31602C7.61755 7.34978 9.65122 6 12.0001 6ZM12.0001 2C15.9153 2 19.3049 4.24991 20.9466 7.5273L19.1576 8.42242C17.8443 5.80019 15.1325 4 12.0001 4C8.86783 4 6.15596 5.80019 4.84271 8.42242L3.05371 7.5273C4.69541 4.24991 8.08503 2 12.0001 2Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
