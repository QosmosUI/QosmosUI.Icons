// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHandSaw : ComponentBase
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
		builder.AddAttribute(14, "d", "M430 34.438l-296.563 238.5 20 20.437 3.844 3.906-1.718 5.22-6.718 20.22 42.906 46.374 32.78-34.97 5.75-27.937 26.532-6.468 4.063-24.814 24.188-5.312 1.593-22.156 26.22-7.532 3.03-20.78 22.125-6.064 6.47-21.562 21.75-8.5 6.25-18.28 17.5-7.095 4.22-16.125 17.53-7.063 3.5-15.5 17.28-6.624 3.845-17.188 15.844-3.813 2.5-17.187 14.5-.97 16.874-18L430 34.438zM113.03 277.813L28.938 339c15.382 51.32 48.128 92.382 86.876 130.906l71.656-78.875L132 331.064l-3.594-3.907 1.656-5.062 6.688-20.063-23.72-24.217zm-17.78 32.093l5.25 5.688 63.78 69.375 5.657 6.124-5.718 6.094-37.814 40.53-13.187 14.094-2.314-19.156c-4.643-38.057-20.223-65.16-52.875-81.406l-13.81-6.875L57 335.72l31.844-21.5 6.406-4.314z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
