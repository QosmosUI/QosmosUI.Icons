// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLightningShadow : ComponentBase
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
		builder.AddAttribute(14, "d", "M54.03 18.307l78.24 70.582-59.465 63.23 47.46 32.337c-12.38 20.72-11.76 47.146 1.848 67.297-41.062 42.994-76.7 92.232-103.752 147.098v94.705h210.83l54.38-56.323-137.246-56.648 32.123-88.188-4.672 71.834 30.37 12.85 47.302-136.66-21.504-3.96c-3.048 7.756-7.685 15.022-13.935 21.272v.002c-21.728 21.727-55.685 24.084-80.098 7.12 4.4-4.59 8.858-9.117 13.383-13.563 16.895 10.054 38.918 7.807 53.5-6.773 3.475-3.476 6.236-7.38 8.312-11.532l-35.115-6.468c6.365-5.588 12.814-11.057 19.356-16.372l20.384 2.813c-.046-4.63-.845-9.25-2.357-13.685l19.854 2.588c.835 4.507 1.187 9.085 1.035 13.655l47.713 6.58-29.21 88.61 42.555-.16 114.817-3.378 22.093 87.492 61.4 14.402V256.568l-138.655-.603 71.486-67.25-14.372 42.08 81.54-22.33V54.56c-89.873 12.397-189.27 52.305-277.49 115.64-11.892-10.783-26.992-16.177-42.093-16.177-14.996 0-29.99 5.32-41.844 15.954l-30.798-20.987 57.553-61.197L81.93 18.307h-27.9zm120.015 154.29c9.39 0 18.772 3.02 26.64 9.038-8.005 6.092-15.902 12.386-23.68 18.87l-28.694-19.552c7.678-5.568 16.705-8.357 25.735-8.357zm-38.32 22.393l26.593 18.12c-9.11 8.048-18.04 16.353-26.744 24.943-7.49-13.372-7.44-29.73.15-43.063zm249.87 142.254l-94.335 22.953-5.52 2.442-45.588-13.68-10.433 31.65 102.098 41.197-10.045 71.75h18.87l5.736-40.965 66.087 40.965h35.472l-98.73-61.196 3.14-22.42-.063-.026 8.037-35.107 46.153 42.402-20.88-79.966zm8.88 99.127l93.53 57.187h5.624v-44.354l-99.155-12.832z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
