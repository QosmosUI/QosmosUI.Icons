// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFlatHammer : ComponentBase
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
		builder.AddAttribute(14, "d", "M132.813 27.625l29.593 134.125c4.547 3.588 9.68 4.188 18.063 1.97l5.186-1.376 3.813 3.812 84.218 84.188 3.78 3.78-1.343 5.19c-2.42 9.36-1.483 15.047 3.375 19.905l13.53 13.53 97.533-97.563-13.532-13.53c-3.538-3.54-9.39-4.415-19.655-1.438l-5.313 1.53-3.906-3.906-86.187-86.188-1.626-3.28-1.094-3.314V64.376c-.013-.02-.018-.044-.03-.063L132.81 27.626zM310.592 85.5l-14.156 14.188 43.782 43.78 14.186-14.155L310.594 85.5zm120.25 95.844l-159.968 159.97 37.063 37.123 160-160-37.094-37.093zM196.5 199.594l-175 175v87.594l218.813-218.782-43.813-43.812z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
