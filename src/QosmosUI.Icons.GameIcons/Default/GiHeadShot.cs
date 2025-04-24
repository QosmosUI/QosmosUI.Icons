// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHeadshot : ComponentBase
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
		builder.AddAttribute(14, "d", "M324.55 177A69 69 0 0 1 264 238v-29a40.7 40.7 0 0 1-16 .05v29a69.25 69.25 0 0 1-60.84-61h29a40.59 40.59 0 0 1 .1-16h-29.1A69.67 69.67 0 0 1 248 100.58v29a40.7 40.7 0 0 1 16 .05v-29c32 3.68 56.87 29.42 60.55 60.42h-29.07a40.59 40.59 0 0 1 .1 16h29zm120.31 79c0 131.42-84.72 238.33-188.86 238.33-104.14 0-188.86-106.91-188.86-238.33 0-131.42 84.72-238.33 188.86-238.33 104.14 0 188.86 106.91 188.86 238.33zm-228.7 39.53c0-10.7-17.85-19.38-39.87-19.38-22.02 0-39.87 8.68-39.87 19.38s17.85 19.38 39.87 19.38c22.02 0 39.87-8.67 39.87-19.38zM264 254.06A85.59 85.59 0 0 0 340.64 177H364v-16h-23.36C336.84 121 304 88.29 264 84.49V64h-16v20.49A85.35 85.35 0 0 0 171.07 161H146v16h25.07A85 85 0 0 0 248 254.06V273h16v-18.94zm112.83 41.48c0-10.7-17.85-19.38-39.87-19.38-22.02 0-39.87 8.68-39.87 19.38s17.85 19.38 39.87 19.38c22.02 0 39.87-8.68 39.87-19.39z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
