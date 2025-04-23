// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiVeepee : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.808 9.941a11.55 11.55 0 0 0-.872-3.51c.784-1.634 1.59-2.239 1.59-2.239s1.658 4.244.203 8.605c-.9 2.698-1.977 4.328-2.554 5.028-.129.156-.243.205-.172.11 1.36-1.834 2.109-4.749 1.805-7.994m1.317 5.143c-.672.809-1.35 1.594-2.1 2.195-.108.086-.176.08-.093-.011 2.653-2.896 5.536-9.314 1.8-15.64 0 0-1.477 1.02-2.69 3.134C15.846 2.922 14.106 1.379 11.94 0c0 0-5.479 6.107-3.056 14.954-6.99.964-4.452 6.361-3.344 7.137.052.037.096.018.025-.091-.393-.603-1.491-2.71.773-4.732 1.215-1.084 3.761-1.367 3.761-1.367-.579-4.248-.538-8.086 2.364-12.333.371.246 4.616 2.112 4.776 8.396.355 3.941-1.691 7.096-3.677 8.324-3.519 1.888-7.468 2.814-10.901 3.619-.291.069-.178.1.016.092 8.156-.343 15.407-4.011 18.195-7.512.537-.673.777-1.414.415-1.824-.361-.411-1.016.244-1.162.421");
		builder.CloseElement();
		builder.CloseElement();
    }
}
