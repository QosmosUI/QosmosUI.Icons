// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiPopeCrown : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 29.337v23h-23v18h23v30.71c3.042-.46 6.046-.71 9-.71 2.954 0 5.958.25 9 .71v-30.71h23v-18h-23v-23h-18zm9 89c-2.13 0-4.48.282-7 .805v309.8c4.678-.154 9.322-.154 14 0v-309.8c-2.52-.523-4.87-.805-7-.805zm-25.002 7.318c-17.49 8.458-38.558 23.73-58.012 43.12-30.294 30.198-57.61 69.585-68.416 103.308-18.06 56.354-1.17 117.767 28.424 178.756 43.848-10.937 72.82-17.792 98.004-20.583V125.655zm50.004 0v304.602c25.183 2.79 54.156 9.646 98.004 20.582 29.595-60.99 46.483-122.403 28.424-178.757-10.807-33.723-38.122-73.11-68.416-103.307-19.454-19.39-40.523-34.663-58.012-43.12zM256 446.337c-3.78 0-7.558.033-11.324.09-25.686 1.59-54.423 8.623-103.608 20.922l7.657 15.313c101.827-28.995 112.723-28.995 214.55 0l7.657-15.314c-49.185-12.3-77.922-19.333-103.608-20.923-3.766-.057-7.545-.09-11.324-.09z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
