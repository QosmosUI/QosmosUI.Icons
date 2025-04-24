// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiConwayLifeGlider : ComponentBase
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
		builder.AddAttribute(14, "d", "M19.51 19.51V492.3H492.3V19.51H19.51zm18 18H171.1V171.1H37.51V37.51zm151.59 0h133.6V171.1H189.1V37.51zm151.6 0h133.6V171.1H340.7V37.51zm-84.8 9.94a56.85 56.85 0 0 0-56.8 56.85 56.85 56.85 0 0 0 56.8 56.9 56.85 56.85 0 0 0 56.9-56.9 56.85 56.85 0 0 0-56.9-56.85zM37.51 189.1H171.1v133.6H37.51V189.1zm151.59 0h133.6v133.6H189.1V189.1zm151.6 0h133.6v133.6H340.7V189.1zm66.9 10a56.85 56.85 0 0 0-56.8 56.8 56.85 56.85 0 0 0 56.8 56.9 56.85 56.85 0 0 0 56.8-56.9 56.85 56.85 0 0 0-56.8-56.8zM37.51 340.7H171.1v133.6H37.51V340.7zm151.59 0h133.6v133.6H189.1V340.7zm151.6 0h133.6v133.6H340.7V340.7zm-236.4 10.1a56.85 56.85 0 0 0-56.85 56.8 56.85 56.85 0 0 0 56.85 56.8 56.85 56.85 0 0 0 56.9-56.8 56.85 56.85 0 0 0-56.9-56.8zm151.6 0a56.85 56.85 0 0 0-56.8 56.8 56.85 56.85 0 0 0 56.8 56.8 56.85 56.85 0 0 0 56.9-56.8 56.85 56.85 0 0 0-56.9-56.8zm151.7 0a56.85 56.85 0 0 0-56.8 56.8 56.85 56.85 0 0 0 56.8 56.8 56.85 56.85 0 0 0 56.8-56.8 56.85 56.85 0 0 0-56.8-56.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
