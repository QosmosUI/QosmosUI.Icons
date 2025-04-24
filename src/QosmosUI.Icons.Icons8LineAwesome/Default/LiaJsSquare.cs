// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaJsSquare : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5 5 L 5 27 L 27 27 L 27 5 L 5 5 z M 7 7 L 25 7 L 25 25 L 7 25 L 7 7 z M 20.244141 15 C 18.819141 15 17.898438 15.912141 17.898438 17.119141 C 17.898437 18.430141 18.667172 19.056781 19.826172 19.550781 L 20.226562 19.722656 C 20.958563 20.045656 21.394531 20.234156 21.394531 20.785156 C 21.394531 21.250156 20.967734 21.583984 20.302734 21.583984 C 19.514734 21.583984 19.066609 21.166469 18.724609 20.605469 L 17.414062 21.355469 C 17.879062 22.286469 18.847844 23 20.339844 23 C 21.859844 23 23 22.211578 23 20.767578 C 23 19.418578 22.230328 18.819234 20.861328 18.240234 L 20.462891 18.068359 C 19.769891 17.764359 19.474609 17.564844 19.474609 17.089844 C 19.474609 16.699844 19.769141 16.396484 20.244141 16.396484 C 20.710141 16.396484 21.003297 16.595844 21.279297 17.089844 L 22.535156 16.283203 C 22.003156 15.352203 21.270141 15 20.244141 15 z M 14.394531 15.095703 L 14.394531 20.558594 C 14.394531 21.356594 14.052297 21.564453 13.529297 21.564453 C 12.978297 21.564453 12.741141 21.185281 12.494141 20.738281 L 11.183594 21.527344 C 11.563594 22.335344 12.312703 23 13.595703 23 C 15.020703 23 16 22.239172 16 20.576172 L 16 15.095703 L 14.394531 15.095703 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
