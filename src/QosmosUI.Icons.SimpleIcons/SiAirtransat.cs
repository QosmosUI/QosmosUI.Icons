// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAirtransat : ComponentBase
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
		builder.AddAttribute(15, "d", "M17.611 0c-2.931.916-5.68 3.434-8.474 6.137C5.564 6.32 1.672 7.74 1.26 7.969c4.122 2.152 5.129 3.115 5.129 3.115s-1.374 3.938-1.649 6.457c.916-2.244 2.702-5.312 3.801-6.777-1.511-1.237-4.35-2.565-4.35-2.565s2.244-.962 6.733-1.191c0 0 1.878-3.619 6.687-7.008zm-2.244 3.344c-.412.87-1.146 2.793-1.283 4.213 3.16.229 5.312.963 5.312.963s-3.205 1.19-4.992 2.609c.32.779 1.055 3.07 1.467 4.855-.687-.64-2.748-2.336-4.26-3.252C9.596 13.511 4.1 18.962 1.031 24c1.328-1.374 5.267-5.817 10.58-9.023 1.1.64 6.137 3.939 6.137 3.939s-1.1-5.862-1.512-7.236c1.558-1.054 4.214-2.52 6.733-3.3-3.527-1.419-7.832-1.784-7.832-1.784s-.09-1.1.23-3.252z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
