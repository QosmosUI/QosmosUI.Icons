// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGraspingClaws : ComponentBase
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
		builder.AddAttribute(14, "d", "M233.156 36.156c-6.48-.048-13.395 1.184-20.47 3.625-16.957 5.854-33.577 18.887-43.467 36.157 77.39 68.916 107.53 126.832 108.06 219.25 43.458-77.778 36.565-167.55-17.217-248.218-6.928-7.206-16.306-10.736-26.907-10.814zm93.78 35.375c-6.478-.047-13.393 1.185-20.467 3.626-2.493.86-4.982 1.902-7.44 3.063 14.802 31.958 23.134 65.038 24.75 97.936 32.99 45.06 46.945 91.825 47.314 154.375 43.432-77.787 36.5-167.58-17.313-248.25-6.92-7.15-16.28-10.67-26.842-10.75zm70.783 49.564c-.51-.004-1.018.02-1.533.03 19.362 45.11 25.912 92.202 19.032 137.75 18.285 35.42 26.38 73.767 26.655 121.22 43.436-77.79 36.502-167.58-17.313-248.25-6.92-7.15-16.282-10.672-26.843-10.75zM86.905 235.064c-9.708.257-19.153 2.586-27.125 6.467-14.347 6.987-22.985 17.96-22.81 30.595 8.884 44.736 21.04 77.706 40.718 100.688 16.145 18.856 37.66 31.635 68.406 39.156-39.886-58.353-46.966-90.635-41.688-175.033-4.366-1.084-8.854-1.69-13.312-1.843-1.394-.05-2.8-.068-4.188-.03z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
