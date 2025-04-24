// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPivotaltracker : ComponentBase
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
		builder.AddAttribute(15, "d", "M12.002 0c-6.617 0-12 5.382-12 11.998 0 6.618 5.384 12.002 12 12.002S24 18.616 24 11.998C24 5.382 18.619 0 12.002 0zm0 2.43a9.568 9.568 0 0 1 9.568 9.568c0 5.286-4.283 9.572-9.568 9.572-5.285 0-9.57-4.286-9.57-9.572 0-5.285 4.285-9.568 9.57-9.568zm-.135 1.31L8.822 5.498V5.5l2.68 4.64c.425-.113.888-.08 1.31.118l1.41-2.442-2.355-4.076zm4.17 2.256l-2.68 4.643c.325.324.52.749.557 1.195h2.816l2.356-4.076-3.049-1.762zM4.781 7.984v3.55h.002v-.03h5.36a1.904 1.904 0 0 1 .756-1.08L9.49 7.984H4.781zm2.487 4.182L4.912 16.24l3.049 1.762 2.682-4.645a1.929 1.929 0 0 1-.557-1.191H7.268zm6.59.33a1.904 1.904 0 0 1-.756 1.078l1.41 2.442h4.707v-3.52h-5.362zm-2.67 1.244l-1.41 2.442 2.353 4.076 3.049-1.76-2.68-4.64c-.425.114-.89.08-1.313-.118z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
