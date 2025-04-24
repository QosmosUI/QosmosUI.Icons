// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSunrise : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32l-64 80h32v64h64v-64h32l-64-80zm-9 187v80h18v-80h-18zm-63.992 53.602l-16.631 6.886 15.309 36.955 16.628-6.886-15.306-36.955zm145.984 0l-15.306 36.955 16.628 6.886 15.309-36.955-16.63-6.886zM77.795 284.068l-12.727 12.727 56.569 56.568 12.726-12.726-56.568-56.569zm356.41 0l-56.568 56.569 12.726 12.726 56.569-56.568-12.727-12.727zM256 337.994a118.919 118.919 0 0 0-59.5 15.95c-34.215 19.754-56.177 55.048-59.129 94.056H374.63c-2.952-39.008-24.914-74.302-59.129-94.057a118.919 118.919 0 0 0-59.5-15.949zM66.488 387.377l-6.886 16.63 36.955 15.307 6.886-16.628-36.955-15.309zm379.024 0l-36.955 15.309 6.886 16.628 36.955-15.306-6.886-16.631zM24 466v18h464v-18H24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
