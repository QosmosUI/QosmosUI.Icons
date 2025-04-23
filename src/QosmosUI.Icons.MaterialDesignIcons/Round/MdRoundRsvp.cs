// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundRsvp : ComponentBase
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
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M0,0h24v24H0V0z");
		builder.AddAttribute(16, "fill", "none");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(17, "g");
		builder.OpenElement(18, "g");
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M16.54,9L16.54,9c0.48,0,0.83,0.46,0.69,0.92l-1.27,4.36C15.84,14.71,15.44,15,15,15h0c-0.44,0-0.84-0.29-0.96-0.72 l-1.27-4.36C12.63,9.46,12.98,9,13.46,9h0c0.32,0,0.6,0.21,0.69,0.52L15,12.43l0.85-2.91C15.94,9.21,16.22,9,16.54,9z M5.1,12.9 l0.49,1.14C5.78,14.49,5.45,15,4.96,15h0c-0.28,0-0.53-0.17-0.63-0.42L3.65,13H2.5v1.31C2.5,14.69,2.19,15,1.81,15H1.69 C1.31,15,1,14.69,1,14.31V10c0-0.55,0.45-1,1-1h2.5C5.33,9,6,9.67,6,10.5v1C6,12.1,5.6,12.65,5.1,12.9z M4.5,10.5h-2v1h2V10.5z M21.5,13h-2v1.25c0,0.41-0.34,0.75-0.75,0.75l0,0C18.34,15,18,14.66,18,14.25V10c0-0.55,0.45-1,1-1h2.5c0.83,0,1.5,0.67,1.5,1.5 v1C23,12.33,22.33,13,21.5,13z M21.5,10.5h-2v1h2V10.5z M11.5,9.75L11.5,9.75c0,0.41-0.34,0.75-0.75,0.75H8.5v0.75h2 c0.55,0,1,0.45,1,1V14c0,0.55-0.45,1-1,1H7.75C7.34,15,7,14.66,7,14.25v0c0-0.41,0.34-0.75,0.75-0.75H10v-0.75H7.75 C7.34,12.75,7,12.41,7,12v-2c0-0.55,0.45-1,1-1h2.75C11.16,9,11.5,9.34,11.5,9.75z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
