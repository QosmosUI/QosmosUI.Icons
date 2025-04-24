// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaSketch : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 3.9902344 L 8.4335938 5.0703125 L 2.7304688 13.056641 L 16 28.537109 L 29.267578 13.056641 L 23.564453 5.0703125 L 16 3.9902344 z M 13.470703 6.3710938 L 10.203125 10.105469 L 10.429688 6.8066406 L 13.470703 6.3710938 z M 18.529297 6.3710938 L 21.570312 6.8046875 L 21.796875 10.105469 L 18.529297 6.3710938 z M 16 6.5195312 L 20.796875 12 L 11.203125 12 L 16 6.5195312 z M 8.2949219 8.7070312 L 8.0664062 12 L 5.9433594 12 L 8.2949219 8.7070312 z M 23.705078 8.7089844 L 26.056641 12 L 23.933594 12 L 23.705078 8.7089844 z M 6.1757812 14 L 8.3828125 14 L 11.472656 20.181641 L 6.1757812 14 z M 10.619141 14 L 21.380859 14 L 16 24.763672 L 10.619141 14 z M 23.617188 14 L 25.824219 14 L 20.527344 20.181641 L 23.617188 14 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
