// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSubway : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M136.1 37.15L105.4 328.8l26.3 26.3h248.6l26.3-26.3-30.7-291.65H361v44H151v-44zm32.9 0v26h174v-26zm-16.9 60h207.8l18.3 145.95H133.8zm15.8 17.95l-13.7 110h203.6l-13.7-110zm-7.9 158c18.1 0 33 14.9 33 33 0 18.2-14.9 33-33 33s-33-14.8-33-33c0-18.1 14.9-33 33-33zm192 0c18.1 0 33 14.9 33 33 0 18.2-14.9 33-33 33s-33-14.8-33-33c0-18.1 14.9-33 33-33zm-192 18c-8.4 0-15 6.7-15 15 0 8.4 6.6 15 15 15s15-6.6 15-15c0-8.3-6.6-15-15-15zm192 0c-8.4 0-15 6.7-15 15 0 8.4 6.6 15 15 15s15-6.6 15-15c0-8.3-6.6-15-15-15zm-204.5 82L91.6 486.8h46.8l13.5-28.7h208.2l13.5 28.7h46.8l-55.9-113.7h-42.4l6.3 14H183.6l6.3-14zm28 32h161l10.2 23H165.3z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
